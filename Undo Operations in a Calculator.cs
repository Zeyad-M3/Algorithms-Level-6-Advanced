//using System;
//using System.Collections.Generic;
//using static Undo_Operations_in_a_Calculator.Calculator;

//class Undo_Operations_in_a_Calculator
//{
//    public class Calculator
//    {
//        public enum Operation
//        {
//            Add = 1,
//            Subtract = 2,
//            Multiply = 3,
//            Divide = 4
//        }

//        public static double Calculate(double a, double b, Operation op)
//        {
//            switch (op)
//            {
//                case Operation.Add:
//                    return a + b;
//                case Operation.Subtract:
//                    return a - b;
//                case Operation.Multiply:
//                    return a * b;
//                case Operation.Divide:
//                    return b != 0 ? a / b : double.NaN;
//                default:
//                    return 0;
//            }
//        }
//    }

//    // دالة لإضافة عملية إلى السجل
//    public static void HistoryPush(
//        Stack<string> historyNames,
//        Stack<double> historyOperand1,
//        Stack<double> historyOperand2,
//        Stack<Calculator.Operation> historyOperations,
//        Stack<double> historyResults,
//        string name,
//        double n1,
//        double n2,
//        Calculator.Operation op)
//    {
//        double result = Calculate(n1, n2, op);

//        historyNames.Push(name);
//        historyOperand1.Push(n1);
//        historyOperand2.Push(n2);
//        historyOperations.Push(op);
//        historyResults.Push(result);
//    }

//    static void Main(string[] args)
//    {
//        // إنشاء الـ Stacks
//        Stack<string> historyNames = new Stack<string>();
//        Stack<double> historyOperand1 = new Stack<double>();
//        Stack<double> historyOperand2 = new Stack<double>();
//        Stack<Calculator.Operation> historyOperations = new Stack<Calculator.Operation>();
//        Stack<double> historyResults = new Stack<double>();

//        string operationName = "KOKO176";
//        double n1 = 4, n2 = 2;
//        Calculator.Operation op = Calculator.Operation.Multiply;

//        // عمليات إدخال
//        HistoryPush(historyNames, historyOperand1, historyOperand2, historyOperations, historyResults, operationName, n1, n2, op);
//        HistoryPush(historyNames, historyOperand1, historyOperand2, historyOperations, historyResults, operationName, 4, 7, op);

//        // إضافة 5 عمليات متتابعة
//        for (int i = 0; i < 5; i++)
//        {
//            HistoryPush(historyNames, historyOperand1, historyOperand2, historyOperations, historyResults, operationName+i, i, n1 + n2 + i, op);
//        }

//        // عرض السجل بالكامل
//        Console.WriteLine("\nAll Operations History:");
//        var ops = historyOperations.ToArray();
//        var op1s = historyOperand1.ToArray();
//        var op2s = historyOperand2.ToArray();
//        var results = historyResults.ToArray();
//        var names = historyNames.ToArray();

//        for (int i = 0; i < ops.Length; i++)
//        {
//            Console.WriteLine($"{names[i]}: {op1s[i]} {ops[i]} {op2s[i]} = {results[i]}");
//        }

//        // تنفيذ عمليتي تراجع (Undo)
//        Console.WriteLine("\nUndo Operations:");
//        Console.WriteLine($"{historyNames.Pop()}: {historyOperand1.Pop()} {historyOperations.Pop()} {historyOperand2.Pop()} = {historyResults.Pop()}");
//        Console.WriteLine($"{historyNames.Pop()}: {historyOperand1.Pop()} {historyOperations.Pop()} {historyOperand2.Pop()} = {historyResults.Pop()}");
//        Console.WriteLine($"{historyNames.Pop()}: {historyOperand1.Pop()} {historyOperations.Pop()} {historyOperand2.Pop()} = {historyResults.Pop()}");
//        Console.WriteLine($"{historyNames.Pop()}: {historyOperand1.Pop()} {historyOperations.Pop()} {historyOperand2.Pop()} = {historyResults.Pop()}");
//        Console.WriteLine($"{historyNames.Pop()}: {historyOperand1.Pop()} {historyOperations.Pop()} {historyOperand2.Pop()} = {historyResults.Pop()}");
//    }
//}
