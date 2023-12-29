namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //입력받기 과제
            /*
            bool Exit = false;
            while (!Exit)
            {
                Console.Write("이름과 나이를 입력해주세요(※ 띄워쓰기로 구분) : ");
                var data = Console.ReadLine().Split(" ");
                string name = data[0];
                if (data.Length < 2)
                {
                    Console.WriteLine("띄워쓰기가 없습니다!");
                    continue;
                }
                string age = data[1];

                if (!int.TryParse(age, out int checkInt))
                {
                    Console.WriteLine("나이가 숫자가 아닙니다!");
                    continue;
                }
                Console.WriteLine($"당신의 이름은 {name}이고, 당신의 나이는 {age}입니다!");
                Exit = true;
            }
            */
            //간단한 사칙연산 계산기 만들기
            /*
            bool Exit = false;
            int number = 0;
            while (!Exit)
            {
                Console.WriteLine("================================");
                Console.WriteLine("사칙연산 계산기입니다!");
                Console.WriteLine("사용하실 연산 방식을 골라주세요!");
                Console.WriteLine("1번 + / 2번 - / 3번 % / 4번 *");
                Console.WriteLine("================================");
                Console.Write("입력 : ");
                var data = Console.ReadLine();
                if(data == null) {
                    Console.WriteLine("입력하지 않으셨습니다!");
                    continue;
                }
                else if (!int.TryParse(data, out int value))
                {
                    Console.WriteLine("숫자가 아닙니다!");
                    continue;
                }
                else if (data.Length > 1)
                {
                    if(data.Length != 2)
                    {
                        Console.WriteLine("잘못된 값입니다!");
                        continue;
                    }
                    number = int.Parse(data.Split("번")[0]);
                    if(number < 0 || number > 4)
                    {
                        Console.WriteLine("잘못된 값입니다!");
                        continue;
                    }
                    Console.WriteLine($"{number}를 고르셨습니다!");
                }else
                {
                    number = int.Parse(data);
                    if (number > 4 || number < 0)
                    {
                        Console.WriteLine("잘못된 값입니다!");
                        continue;
                    }
                }

                Exit = true;
            }

            Exit = false;
            while(!Exit)
            {
                switch(number)
                {
                    case 1:
                        {
                            Console.WriteLine("+ 사칙연산 입니다!");
                            Console.WriteLine("+연산할 두 수를 입력해주세요(띄워쓰기로 구분) : ");
                            var data = Console.ReadLine().Split(" ");
                            if (data.Length < 2)
                            {
                                Console.WriteLine("띄워쓰기가 없습니다!");
                                continue;
                            }else if (int.TryParse(data[0], out int a) && int.TryParse(data[1], out int b))
                            {
                                a = int.Parse(data[0]);
                                b = int.Parse(data[1]);
                                Console.WriteLine($"계산 :  {a} + {b} = {a + b}");
                                Exit = true;
                            }
                            else
                            {
                                Console.WriteLine("숫자가 아닙니다");
                                continue;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("- 사칙연산 입니다!");
                            Console.WriteLine("-연산할 두 수를 입력해주세요(띄워쓰기로 구분) : ");
                            var data = Console.ReadLine().Split(" ");
                            if (data.Length < 2)
                            {
                                Console.WriteLine("띄워쓰기가 없습니다!");
                                continue;
                            }
                            else if (int.TryParse(data[0], out int a) && int.TryParse(data[1], out int b))
                            {
                                a = int.Parse(data[0]);
                                b = int.Parse(data[1]);
                                Console.WriteLine($"계산 :  {a} - {b} = {a - b}");
                                Exit = true;
                            }
                            else
                            {
                                Console.WriteLine("숫자가 아닙니다");
                                continue;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("/ 사칙연산 입니다!");
                            Console.WriteLine("/ 연산할 두 수를 입력해주세요(띄워쓰기로 구분) : ");
                            var data = Console.ReadLine().Split(" ");
                            if (data.Length < 2)
                            {
                                Console.WriteLine("띄워쓰기가 없습니다!");
                                continue;
                            }
                            else if (int.TryParse(data[0], out int a) && int.TryParse(data[1], out int b))
                            {
                                a = int.Parse(data[0]);
                                b = int.Parse(data[1]);
                                Console.WriteLine($"계산 :  {a} % {b} = {(float)a / b}");
                                Exit = true;
                            }
                            else
                            {
                                Console.WriteLine("숫자가 아닙니다");
                                continue;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("* 사칙연산 입니다!");
                            Console.WriteLine("*연산할 두 수를 입력해주세요(띄워쓰기로 구분) : ");
                            var data = Console.ReadLine().Split(" ");
                            if (data.Length < 2)
                            {
                                Console.WriteLine("띄워쓰기가 없습니다!");
                                continue;
                            }
                            else if (int.TryParse(data[0], out int a) && int.TryParse(data[1], out int b))
                            {
                                a = int.Parse(data[0]);
                                b = int.Parse(data[1]);
                                Console.WriteLine($"계산 :  {a} * {b} = {a * b}");
                                Exit = true;
                            }
                            else
                            {
                                Console.WriteLine("숫자가 아닙니다");
                                continue;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"잘못된 오류!{number}");
                            break;
                        }
                }
            }
            */
            //섭씨 -> 화씨계산기
            /*
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("섭씨온도 화씨온도로 변환하는 프로그램입니다.");
                Console.Write("섭씨온도 입력 : ");
                var data = Console.ReadLine().Split(" ");
                Console.WriteLine("============================================");

                if (data.Length > 1)
                {
                    Console.WriteLine($"{data}입력하셨습니다!");
                    continue;
                }else if (int.TryParse(data[0], out int a))
                {
                    a = int.Parse(data[0]);
                    Console.WriteLine($"섭씨 {a}는 화씨{a * 1.8 + 32} 입니다!");
                    isExit = true;
                    continue;
                }
                
            }
            */
            //BMI계산기
            /*
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("BMI계산기 입니다!");
                Console.Write("키와 체중을 입력(※ 띄워쓰기로 구분) : ");
                var data = Console.ReadLine().Split(" ");
                Console.WriteLine("==========================================");
                string sWeight = data[0];
                if (data.Length < 2)
                {
                    Console.WriteLine("띄워쓰기가 없습니다!");
                    continue;
                }
                string sHeight = data[1];

                if (int.TryParse(sHeight, out int height) && int.TryParse(sWeight, out int weight))
                {
                    Console.WriteLine($"당신의 키는 {weight}고 당신의 몸무게는 {height}입니다");
                    float fWeight = weight / 100f;
                    Console.WriteLine($"당신의 BMI는 {(float)height / (fWeight * fWeight):N}");
                    isExit = true;
                    continue;
                }
                Console.WriteLine($"잘못된 값입니다!");
            }
            */
        }
    }
}
