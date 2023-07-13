namespace Sort.Structure
{
    public class MyLinkedList
    {
        private Node _head;
        private int _count = 0;
        public int Count => _count;

        public MyLinkedList()
        {
            _head = null;
        }

        public void Add(int value)
        {
            if (_head is null)
            {
                _head = new Node(value);
                _count++;
                return;
            }

            var node = _head;
            while (node != null)
            {
                if (node.Next is null)
                {
                    node.Next = new Node(value);
                    _count++;
                    break;
                }

                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            return GetEnumerator().ToArray();
        }

        public void RemoveAt(int seq)
        {
            if (seq + 1 > _count)
                return;


            var beforeNode = FindSeqNode(seq, -1);
            var nextNode = FindSeqNode(seq, 1);

            // if(beforeNode)

            if (beforeNode is null)
                _head = nextNode;
            else
                beforeNode.Next = nextNode;

            _count--;
        }

        private Node FindSeqNode(int seq, int offset = default(int))
        {
            var node = _head;
            int newSeq = seq + offset;

            if (newSeq == 0) return _head;

            if (newSeq == -1) return null;

            if (newSeq > _count) return new Node();

            for (int i = 0; i < newSeq; i++)
                node = node.Next;

            return node;
        }

        public IEnumerable<int> GetEnumerator()
        {
            var node = _head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        public int this[int seq]
        {
            get
            {
                return FindSeqNode(seq).Value;
            }
            set
            {
                FindSeqNode(seq).Value = value;
            }
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
            Next = null;
        }

        public Node() : this(0) { }
    }
}