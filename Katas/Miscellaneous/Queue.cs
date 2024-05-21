using System.Collections.Generic;
using System.Linq;

namespace Katas.Miscellaneous
{
    public class Queue
    {
        public Queue()
        {
            Collection = new List<object>();
        }
        public List<object> Collection { get; set; }
        public void Add(object input)
        {
            Collection = Collection.Prepend(input).ToList();
        }

        public object Remove()
        {
            var result = Collection.LastOrDefault();
            if (result != null)
                Collection.Remove(result);

            return result;
        }

        public object Peek()
        {
            return Collection.LastOrDefault();
        }
    }

    public class QueueWeave
    {
        public Queue Weave(Queue firstQueue, Queue secondQueue)
        {
            var result = new Queue();

            while (firstQueue.Peek() != null || secondQueue.Peek() != null)
            {
                if (firstQueue.Peek() != null)
                    result.Add(firstQueue.Remove());

                if (secondQueue.Peek() != null)
                    result.Add(secondQueue.Remove());

            }
            return result;
        }
    }
}
