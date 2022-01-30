using ShapesProgram.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ShapesProgram
{
    public class GraphicEditor
    {
        private bool _isProgramWorking;
        private List<Shape> _createdShapes;
        private (Type, Func<Shape>)[] _shapeTypeHandlers;

        public GraphicEditor()
        {
            _isProgramWorking = false;
            _shapeTypeHandlers = new (Type, Func<Shape>)[]
            {
                (typeof(Ring), OnRingSelected),
                (typeof(Circle), OnCircleSelected),
                (typeof(Ball), OnBallSelected),
                (typeof(Rectangle), OnRectangleSelected),
                (typeof(Square), OnSquareSelected),
                (typeof(Triangle), OnTriangleSelected),
            };
        }

        private string ConsoleSeparator => new string('=', Console.WindowWidth);

        public void Run()
        {
            _createdShapes = new List<Shape>();
            _isProgramWorking = true;
            while (_isProgramWorking)
            {
                ShowOptions();

                char option = Console.ReadKey(true).KeyChar;
                switch (option)
                {
                    case '1':
                        AddShape();
                        break;

                    case '2':
                        ShowShapes();
                        break;

                    case '3':
                        ClearShapes();
                        break;

                    case '4':
                        _isProgramWorking = false;
                        break;
                }

                Console.WriteLine(ConsoleSeparator);
            }
        }

        private void ShowOptions()
            
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Вывести фигуры");
            Console.WriteLine("3. Очистить холст");
            Console.WriteLine("4. Выход");
        }

        private void AddShape()
        {
            Console.WriteLine("Выберите тип фигуры:");
            ShowPossibleShapes();

            char shapeTypeOption = Console.ReadKey(true).KeyChar;
            int shapeTypeIndex = int.Parse(shapeTypeOption.ToString()) - 1;

            Func<Shape> handler = _shapeTypeHandlers[shapeTypeIndex].Item2;
            Shape createdShape = handler();
            _createdShapes.Add(createdShape);
        }

        private void ShowPossibleShapes()
        {
            int i = 1;
            foreach (var (shapeType, handler) in _shapeTypeHandlers)
            {
                Console.WriteLine($"{i}. {shapeType.Name}");
                i++;
            }
        }
        
        private void ShowShapes()
        {
            Console.WriteLine("Ваши фигуры:");
            foreach (var shape in _createdShapes)
            {
                Console.WriteLine($"\t{shape}");
            }
        }

        private void ClearShapes()
        {
            _createdShapes = new List<Shape>();
        }

        private Ring OnRingSelected()
        {
            Vector2 position = GetPositionFromUser();

            Console.WriteLine("Введите внутренний радиус");
            double innerRadius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите внешний радиус");
            double outerRadius = double.Parse(Console.ReadLine());
            
            return new Ring(position, innerRadius, outerRadius);
        }

        private Circle OnCircleSelected()
        {
            Vector2 position = GetPositionFromUser();

            Console.WriteLine("Введите радиус");
            double radius = double.Parse(Console.ReadLine());

            return new Circle(position, radius);
        }

        private Ball OnBallSelected()
        {
            Vector2 position = GetPositionFromUser();

            Console.WriteLine("Введите радиус");
            double radius = double.Parse(Console.ReadLine());

            return new Ball(position, radius);
        }

        private Rectangle OnRectangleSelected()
        {
            Vector2 position = GetPositionFromUser();

            Console.WriteLine("Введите ширину");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту");
            double height = double.Parse(Console.ReadLine());

            return new Rectangle(position, width, height);

        }

        private Square OnSquareSelected()
        {
            Vector2 position = GetPositionFromUser();

            Console.WriteLine("Введите длину стороны");
            double size = double.Parse(Console.ReadLine());

            return new Square(position, size);
        }

        private Triangle OnTriangleSelected()
        {
            Vector2 position = GetPositionFromUser();
            double[] sides = new double[] { 0, 0, 0 };

            Console.WriteLine("Введите длину первой стороны");
            sides[0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны");
            sides[1] = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину третьей стороны");
            sides[2] = double.Parse(Console.ReadLine());

            return new Triangle(position, sides);
        }

        private Vector2 GetPositionFromUser()
        {
            Console.WriteLine("Введите координаты центра через пробел");

            var coordinates = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(parameter => double.Parse(parameter))
                .ToList();

            return new Vector2((float)coordinates[0], (float)coordinates[1]);
        }
    }
}
