using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TrainManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateAndWriteTrainsToFile();
            ReadTrainsFromFile();
        }

        private void GenerateAndWriteTrainsToFile()
        {
            Random random = new Random();
            List<Train> trains = new List<Train>();
            for (int i = 0; i < 10; i++)
            {
                Train train = new Train
                {
                    Destination = GenerateRandomDestination(),
                    TrainNumber = random.Next(100, 1000),
                    DepartureTime = DateTime.Now.AddHours(random.Next(1, 24))
                };
                trains.Add(train);
            }

            using (StreamWriter writer = new StreamWriter("trains.txt"))
            {
                foreach (var train in trains)
                {
                    writer.WriteLine($"{train.Destination},{train.TrainNumber},{train.DepartureTime}");
                }
            }
        }
        // Генерация случайного пункта назначения
        private string GenerateRandomDestination()
        {
            string[] destinations = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Казань", "Нижний Новгород", "Челябинск", "Самара", "Омск", "Ростов-на-Дону" };
            Random random = new Random();
            return destinations[random.Next(destinations.Length)];
        }

        private void ReadTrainsFromFile()
        {
            listBoxTrains.Items.Clear();
            using (StreamReader reader = new StreamReader("trains.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Train train = new Train
                        {
                            Destination = parts[0],
                            TrainNumber = int.Parse(parts[1]),
                            DepartureTime = DateTime.Parse(parts[2])
                        };
                        listBoxTrains.Items.Add(train);
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string destination = textBoxDestination.Text;
            List<Train> foundTrains = new List<Train>();
            for (int i = 0; i < listBoxTrains.Items.Count; i++)
            {
                Train train = (Train)listBoxTrains.Items[i];
                if (train.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                {
                    foundTrains.Add(train);
                }
            }

            if (foundTrains.Count > 0)
            {
                DisplayFoundTrains(foundTrains);
            }
            else
            {
                MessageBox.Show("Поезда в указанный пункт назначения не найдены.");
            }
        }

        private void DisplayFoundTrains(List<Train> trains)
        {
            string message = "Поезда в указанный пункт назначения:\n";
            foreach (var train in trains)
            {
                message += $"{train}\n";
            }
            MessageBox.Show(message);
        }

        private void buttonGenerateDestination_Click(object sender, EventArgs e)
        {
            textBoxDestination.Text = GenerateRandomDestination();
        }
    }

    public class Train
    {
        public string Destination { get; set; }
        public int TrainNumber { get; set; }
        public DateTime DepartureTime { get; set; }

        public override string ToString()
        {
            return $"{Destination} - Поезд №{TrainNumber}, Отправление: {DepartureTime}";
        }
    }
}
