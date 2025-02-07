using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        #region List<T>（动态数组）
        //// 初始化
        //List<string> fruits = new List<string> { "Apple", "Banana" };

        //// 添加元素
        //fruits.Add("Cherry");
        //fruits.AddRange(new[] { "Date", "Elderberry" });

        //// 访问元素
        //Console.WriteLine(fruits[0]); // Apple

        //// 遍历
        //foreach (var fruit in fruits)
        //{
        //    Console.WriteLine(fruit);
        //}

        //// 查找
        //int index = fruits.IndexOf("Banana"); // 返回1,返回指定元素的索引。如果找不到，返回 -1。
        //Console.WriteLine($"Index of 'Banana': {index}");

        //var result = fruits.Find(f => f.StartsWith("C")); // Cherry
        //Console.WriteLine($"First fruit starting with 'C': {result}");

        //// 删除
        //fruits.Remove("Date");
        //fruits.RemoveAt(0);

        //// 排序
        //fruits.Sort(); // 按字母顺序排序

        //// 转换为数组
        //string[] array = fruits.ToArray();

        //// 打印排序后的集合和数组
        //Console.WriteLine("Sorted list:");
        //foreach (var fruit in fruits)
        //{
        //    Console.WriteLine(fruit);
        //}

        //Console.WriteLine("Array:");
        //foreach (var fruit in array)
        //{
        //    Console.WriteLine(fruit);
        //}
        #endregion

        #region Dictionary<TKey, TValue>（键值对集合）
        //// 初始化
        //Dictionary<int, string> employees = new Dictionary<int, string> {
        //    { 101, "Alice" },
        //    { 102, "Bob" }
        //};

        //// 添加元素
        //employees.Add(103, "Charlie");  
        //employees[104] = "David"; // 索引器方式

        //// 访问元素
        //if (employees.TryGetValue(102, out string name))
        //{
        //    Console.WriteLine(name); // Bob
        //}

        //// 遍历键值对
        //foreach (KeyValuePair<int, string> kvp in employees)
        //{
        //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        //}
        //// 检查存在性
        //bool hasKey = employees.ContainsKey(105); // false
        //bool hasValue = employees.ContainsValue("Alice"); // true
        //Console.WriteLine($"Contains key 105: {hasKey}");
        //Console.WriteLine($"Contains value 'Alice': {hasValue}");
        //// 删除元素
        //employees.Remove(101);

        //// 自定义对象作为键
        //Dictionary<Product, decimal> prices = new Dictionary<Product, decimal>();

        //// 添加自定义对象作为键
        //prices.Add(new Product { Id = 1 }, 10.99m);
        //prices.Add(new Product { Id = 2 }, 20.99m);

        //// 访问自定义对象作为键
        //foreach (KeyValuePair<Product, decimal> kvp in prices)
        //{
        //    Console.WriteLine($"Product ID: {kvp.Key.Id}, Price: {kvp.Value}");
        //}
        #endregion

        #region HashSet<T>（唯一元素集合）
        //// 初始化
        //HashSet<int> primeNumbers = new HashSet<int> { 2, 3, 5, 7 };

        //// 添加元素
        //primeNumbers.Add(11);
        //bool added = primeNumbers.Add(3); // 返回false（已存在）
        //Console.WriteLine($"Added 3: {added}");

        //// 检查存在性
        //bool hasFive = primeNumbers.Contains(5); // true
        //Console.WriteLine($"Contains 5: {hasFive}");

        //// 集合运算
        //HashSet<int> evenNumbers = new HashSet<int> { 2, 4, 6, 8 };

        //// 并集（修改原集合）
        //primeNumbers.UnionWith(evenNumbers); // {2,3,5,7,11,4,6,8}
        //Console.WriteLine("Union with even numbers:");
        //foreach (var num in primeNumbers)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        //// 交集
        //HashSet<int> intersection = new HashSet<int>(primeNumbers);
        //intersection.IntersectWith(evenNumbers); // {2}
        //Console.WriteLine("Intersection with even numbers:");
        //foreach (var num in intersection)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        //// 差集
        //primeNumbers.ExceptWith(evenNumbers); // {3,5,7,11}
        //Console.WriteLine("Except with even numbers:");
        //foreach (var num in primeNumbers)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();

        //// 删除元素
        //primeNumbers.RemoveWhere(n => n > 10); // 删除11
        //Console.WriteLine("After removing numbers greater than 10:");
        //foreach (var num in primeNumbers)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();
        #endregion
        #region Queue<T>（先进先出队列）
        // 初始化
        Queue<string> tasks = new Queue<string>();

        // 添加元素
        tasks.Enqueue("Process data");
        tasks.Enqueue("Generate report");

        // 移除并获取元素
        string nextTask = tasks.Dequeue(); // Process data
        Console.WriteLine($"Next task: {nextTask}");

        // 查看队列前端的元素
        string peekTask = tasks.Peek();    // Generate report
        Console.WriteLine($"Peek task: {peekTask}");

        // 遍历队列
        Console.WriteLine("Remaining tasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
        #endregion
        #region Stack<T>（后进先出栈）
        // 初始化
        Stack<int> numbers = new Stack<int>();

        // 添加元素
        numbers.Push(10);
        numbers.Push(20);

        // 移除并获取顶部元素
        int top = numbers.Pop(); // 20
        Console.WriteLine($"Popped top element: {top}");

        // 查看栈顶部的元素
        int peek = numbers.Peek(); // 10
        Console.WriteLine($"Peeked top element: {peek}");

        // 遍历栈
        Console.WriteLine("Remaining elements in the stack:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        #endregion
        #region LinkedList<T>（双向链表）
        // 初始化
        LinkedList<string> chain = new LinkedList<string>();

        // 添加元素
        chain.AddLast("First");
        chain.AddLast("Third");

        // 查找节点
        LinkedListNode<string> node = chain.Find("First");

        // 在指定节点后插入新节点
        chain.AddAfter(node, "Second");

        // 遍历链表并打印所有元素
        Console.WriteLine("Elements in the linked list:");
        foreach (var item in chain)
        {
            Console.WriteLine(item);
        }
        #endregion 
    }
    // 自定义对象作为键
    public class Product
    {
        public int Id { get; set; }
        //使得两个 Product 对象的相等性基于它们的 Id，而不是基于它们的内存地址。
        public override int GetHashCode() => Id.GetHashCode();
        public override bool Equals(object obj) => (obj as Product)?.Id == Id;
    }
}