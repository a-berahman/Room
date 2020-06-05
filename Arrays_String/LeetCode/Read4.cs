// /**
//  * The Read4 API is defined in the parent class Reader4.
//  *     int Read4(char[] buf);
//  */
// Read N Characters Given Read4
// public class Solution : Reader4 {
//     /**
//      * @param buf Destination buffer
//      * @param n   Number of characters to read
//      * @return    The number of actual characters read
//      */
    
    
//      public int Read(char[] buf, int n) {
//             var read4buf = new char[4];
//             var readindex = 0;
//             var endoffile = false;

//             while (readindex < n && !endoffile)
//             {
//                 var readbytes = Read4(read4buf);
//                 if (readbytes < 4)
//                 {
//                     endoffile = true;
//                 }

//                 var length = Math.Min(n - readindex, readbytes);
//                 for (int i = 0; i < length; i++)
//                 {
//                     buf[i + readindex] = read4buf[i];
//                 }
//                 readindex += length;
//             }

//             return readindex;
//     }
// }