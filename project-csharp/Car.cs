class Сar
    {
        public string brand;
        public int year;

        public Сar() 
        {
            brand = "неизвестно"; 
            year = 0; 
        }
        public Car(string brand, int year) 
        {
            this.brand = brand;
            this.year = year;
        }

        public void Print()
        {
        Console.WriteLine($"Бренд: {brand} Возраст: {year}");
        }
    }