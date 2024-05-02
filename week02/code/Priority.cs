public static class Priority {
    public static void Test() {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add an item with priority 1
        // Expected Result: The item should be added to the priority queue
        priorityQueue.Enqueue("Item 1", 1);
        Console.WriteLine("Test 1");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add an item with priority 2 and then add an item with priority 1
        // Expected Result: The item with priority 2 should be at the front of the priority queue
        priorityQueue.Enqueue("Item 2", 2);
        priorityQueue.Enqueue("Item 3", 1);
        Console.WriteLine("Test 2");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Add multiple items with the same high priority
        // Expected Result: The item closest to the front of the queue with the highest priority should be removed
        priorityQueue.Enqueue("Item 4", 3);
        priorityQueue.Enqueue("Item 5", 3);
        priorityQueue.Enqueue("Item 6", 2);
        Console.WriteLine("Test 3");
        Console.WriteLine(priorityQueue);
        var dequeuedItem = priorityQueue.Dequeue();
        Console.WriteLine("Dequeued item: " + dequeuedItem);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Dequeue from an empty queue
        // Expected Result: An error message should be displayed
        var emptyQueue = new PriorityQueue();
        try {
            emptyQueue.Dequeue();
            Console.WriteLine("Test 4");
            Console.WriteLine("Error: Dequeue from an empty queue did not throw an error");
        } catch (Exception ex) {
            Console.WriteLine("Test 4");
            Console.WriteLine("Error message: " + ex.Message);
        }
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}