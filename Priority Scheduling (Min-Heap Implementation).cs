//using System;
//using System.Collections.Generic;

//class TaskItem
//{
//    public string Name { get; set; }
//    public int Priority { get; set; }

//    public TaskItem(string name, int priority)
//    {
//        Name = name;
//        Priority = priority;
//    }
//}

//class MinHeap
//{
//    private List<TaskItem> heap = new List<TaskItem>();

//    private int GetParent(int index) => (index - 1) / 2;
//    private int GetLeftChild(int index) => 2 * index + 1;
//    private int GetRightChild(int index) => 2 * index + 2;

//    public int Count => heap.Count;

//    public void Insert(TaskItem task)
//    {
//        heap.Add(task);
//        HeapifyUp(heap.Count - 1);
//    }

//    public TaskItem ExtractMin()
//    {
//        if (heap.Count == 0)
//            throw new InvalidOperationException("Heap is empty!");

//        TaskItem root = heap[0];

//        heap[0] = heap[heap.Count - 1];
//        heap.RemoveAt(heap.Count - 1);

//        HeapifyDown(0);
//        return root;
//    }

//    private void HeapifyUp(int index)
//    {
//        while (index > 0 && heap[index].Priority < heap[GetParent(index)].Priority)
//        {
//            Swap(index, GetParent(index));
//            index = GetParent(index);
//        }
//    }

//    private void HeapifyDown(int index)
//    {
//        int smallest = index;
//        int left = GetLeftChild(index);
//        int right = GetRightChild(index);

//        if (left < heap.Count && heap[left].Priority < heap[smallest].Priority)
//            smallest = left;

//        if (right < heap.Count && heap[right].Priority < heap[smallest].Priority)
//            smallest = right;

//        if (smallest != index)
//        {
//            Swap(index, smallest);
//            HeapifyDown(smallest);
//        }
//    }

//    private void Swap(int i, int j)
//    {
//        TaskItem temp = heap[i];
//        heap[i] = heap[j];
//        heap[j] = temp;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MinHeap scheduler = new MinHeap();

//        Console.WriteLine("Tasks entered in this order: Task A, Task B, Task C.");
//        scheduler.Insert(new TaskItem("Task A", 3));
//        scheduler.Insert(new TaskItem("Task B", 1));
//        scheduler.Insert(new TaskItem("Task C", 2));

//        Console.WriteLine("\nExecuting tasks in priority order:\n");
//        while (scheduler.Count > 0)
//        {
//            var task = scheduler.ExtractMin();
//            Console.WriteLine($"Task: {task.Name}, Priority: {task.Priority}");
//        }
//    }
//}