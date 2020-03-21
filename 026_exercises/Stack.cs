using System;
using System.Collections;
using System.Collections.Generic;

namespace _026_exercises
{
    /// <summary>
    /// 
    /// </summary>
    public class Stack
    {
        public ArrayList listOfObjects;
        public List<string> objectsAsString;
        /// <summary>
        /// Parameterless constructor of the Stack class.
        /// </summary>
        public Stack()
        {
            listOfObjects = new ArrayList();
            objectsAsString = new List<string>();
        }
        /// <summary>
        /// Pushes the object on top of the stack.
        /// </summary>
        /// <param name="obj"></param>
        public void Push(object obj)
        {
            if (obj != null)
            {
               listOfObjects.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("Not valid object");
            }
        }
        /// <summary>
        /// Returns the last object on the stack and removes it.
        /// </summary>
        /// <returns></returns>
        public string Pop()
        {
            if (listOfObjects.Count != 0)
            {
                var lastObject = listOfObjects[listOfObjects.Count - 1];

                listOfObjects.RemoveAt(listOfObjects.Count - 1);

                return lastObject.ToString();

            }
            else
            {
                throw new InvalidOperationException("Empty list");
            }

        }
        /// <summary>
        /// Clears the list of objects.
        /// </summary>
        public void Clear()
        {
            listOfObjects.Clear();
        }
    }
}
