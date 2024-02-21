//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Scanner;


public class Main {
    public static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.println("Выберерите номер задания: 1 - сложение, 2 - проверка координат, 3 - считаем дискриминант, 4 - ищем четные слова");
        int choice = 0;
        while (choice < 5)
            {
                choice = scanner.nextInt();
                scanner.nextLine();
                switch (choice) {
                    case 1:
                        Add();
                        break;
                    case 2:
                        CirklePointCheker();
                        break;
                    case 3:
                        QuadraticEquationSolver();
                        break;
                    case 4:
                        WordLengthCounter();
                        break;
                    default:
                        System.out.println("Некорректный выбор.");
            }
        }
    }

    public static void Add ()
    {
        System.out.println("Веедите два числа");
        int a = scanner.nextInt();
        int b = scanner.nextInt();
        int result = 0;
        result = a+b;
        System.out.println(result);
    }

    public static void CirklePointCheker()
    {
        System.out.println("Веедите координаты x0, y0");
        double x0 = scanner.nextDouble();
        double y0 = scanner.nextDouble();
        System.out.println("Веедите координаты круга и его радиус");
        System.out.println("Веедите радиус");
        double R = scanner.nextDouble();
        System.out.println("Веедите координаты x, y");
        double x = scanner.nextDouble();
        double y = scanner.nextDouble();

        double distance = Math.sqrt(Math.pow(x - x0, 2) + Math.pow(y - y0, 2));


        if (distance <= R) {
            System.out.println("Попадает.");
        } else {
            System.out.println("Не попадает.");
        }
    }

    public static void QuadraticEquationSolver()
    {
        System.out.println("Введите значние A, B, C");
        double A = scanner.nextDouble();
        double B = scanner.nextDouble();
        double C = scanner.nextDouble();

        double discriminant = B * B - 4 * A * C;


        if (discriminant > 0) {

            double root1 = (-B + Math.sqrt(discriminant)) / (2 * A);
            double root2 = (-B - Math.sqrt(discriminant)) / (2 * A);
            System.out.println("Корень 1: " + root1);
            System.out.println("Корень 2: " + root2);
        } else if (discriminant == 0) {

            double root = -B / (2 * A);
            System.out.println("Корень: " + root);
        } else {
            System.out.println("Уравнение не имеет действительных корней.");
        }
    }

    public static void WordLengthCounter()
    {
        System.out.print("Введите строку: ");
        String inputString = scanner.nextLine();

        String[] words = inputString.split("\\s+");
        int count = 0;

        for (String word : words) {
            String cleanedWord = word.replaceAll("[^а-яА-Яa-zA-Z]", "");

            if (cleanedWord.length() % 2 == 0) {
                count++;
            }
        }

        // Выводим результат
        System.out.println("Количество слов с четным числом символов: " + count);
    }
}