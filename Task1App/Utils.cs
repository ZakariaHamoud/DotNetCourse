public class Utils
{
    public static bool IsInteger(string input)
    {
        try
        {
            Convert.ToInt32(input);
            return true;
        }
        catch
        {
            return false;
        }
    }

   //public static tuple<list<student> , list<student>> getresult(list<student> students)
   //{
   //    list<student> passedstudents = new list<student>();
   //    list<student> failedstudents = new list<student>();
   //
   //    foreach(var student in students) // s1 ,s2 ,s3 ,s4 -- sn
   //    {
   //        if(student.isstudentpassed())
   //        {
   //            passedstudents.add(student);
   //        }
   //        else
   //        {
   //            failedstudents.add(student);
   //        }
   //    }
   //
   //    return new tuple<list<student> , list<student>>(passedstudents , failedstudents);
    //}
}