namespace assignment_c__adv_02
{
    internal class Program
    {


        // Function to reverse the queue
        //static void ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    // Step 1: Dequeue from queue and push onto stack
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    // Step 2: Pop from stack and enqueue back to queue
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //}



        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char parentheses in input)
            {
                if (parentheses == '(' || parentheses == '{' || parentheses == '[')
                {
                    stack.Push(parentheses);
                }
                else if (parentheses == ')' || parentheses == '}' || parentheses == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if ((parentheses == ')' && top != '(') ||
                        (parentheses == '}' && top != '{') ||
                        (parentheses == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region print how many numbers in array that is greater than  X

            //int[] arr = { 1, 5, 2, 7, 3 };
            //int[] queries = { 3, 1, 7 };

            //foreach (int x in queries)
            //{
            //    int count = 0;
            //    foreach (int num in arr)
            //    {
            //        if (num > x)
            //            count++;
            //    }
            //    Console.WriteLine($"Numbers greater than {x}: {count}");
            //}


            #endregion

            #region Determine if it's palindrome or not.
            //Console.Write("Enter the number of elements (N): ");
            //int N = int.Parse(Console.ReadLine());

            //int[] arr = new int[N];

            //Console.WriteLine($"Enter {N} integers:");
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //bool isPalindrome = true;

            //for (int i = 0; i < N / 2; i++)
            //{
            //    if (arr[i] != arr[N - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //    Console.WriteLine("The array is a palindrome.");
            //else
            //    Console.WriteLine("The array is not a palindrome.");


            #endregion

            //#region implement a function to reverse the elements of a queue using a stack

            ////  reverse queue

            //    Queue<int> queue = new Queue<int>();


            //    queue.Enqueue(1);
            //    queue.Enqueue(2);
            //    queue.Enqueue(3);
            //    queue.Enqueue(4);
            //    queue.Enqueue(5);

            //    Console.WriteLine("Original Queue:");
            //    foreach (int item in queue)
            //    {
            //        Console.Write(item + " ");
            //    }

            //    ReverseQueue(queue);

            //    Console.WriteLine("\nReversed Queue:");
            //    foreach (int item in queue)
            //    {
            //        Console.Write(item + " ");
            //    }

            //#endregion

            #region check if a string of parentheses is balanced using a stack

              Console.Write("Enter a string of brackets: ");
        string input = Console.ReadLine();

        if (IsBalanced(input))
            Console.WriteLine("The string is balanced.");
        else
            Console.WriteLine("The string is NOT balanced.");

            #endregion


        }
    }

     



    }


