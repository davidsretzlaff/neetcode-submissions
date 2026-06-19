public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var studentsQueue = new Queue<int>();
        var studentCount = students.Length;
        var count = 0;
        var response = studentCount;
        foreach (var student in students)
        {
            studentsQueue.Enqueue(student);
        }

        foreach (var sandwhich in sandwiches)
        {
            count = 0;
            while (count < studentCount && studentsQueue.Peek() != sandwhich)
            {
                studentsQueue.Enqueue(studentsQueue.Dequeue());
                count ++;
            }
            if (studentsQueue.Peek() == sandwhich)
            {
                response --;
                studentsQueue.Dequeue();
            }
            else break;
        }
        return response;
    }
}