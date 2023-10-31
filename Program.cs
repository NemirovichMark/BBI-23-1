region 1_2
        double counts = 0;
        double countv = 0;
        double n1 = 0;
        double n2 = 0;
        double k = 0;
        while (true)
        {
            Console.Write("Введите координты x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координты y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            k++;
            if ((y>=0) & (y + Math.Abs(x) <= 1)) { countv++; }
            else { counts++; }
            Console.WriteLine("Введите stop для завершения");
            string stop= Console.ReadLine();
            if (stop == "stop")
            {
                break;
            }
        }   
        n1 = countv / k * 100;
        n2 = counts / k * 100;
        Console.WriteLine($"Процент точек внутри треугольника: {n1} %");
        Console.WriteLine($"Процент точек вне треугольника: {n2} %");
        Console.WriteLine();
        #endregion
