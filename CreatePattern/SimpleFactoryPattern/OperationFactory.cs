namespace SimpleFactoryPattern
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;

                case "-":
                    operation = new OpertaionSub();
                    break;

                case "*":
                    operation = new OperationMul();
                    break;

                case "/":
                    operation = new OperationDiv();
                    break;
            }
            return operation;
        }
    }
}
