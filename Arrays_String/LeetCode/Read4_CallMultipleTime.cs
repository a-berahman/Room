// /**
//  * The Read4 API is defined in the parent class Reader4.
//  *     int Read4(char[] buf);
//  */

// Read N Characters Given Read4 II - Call multiple times

// public class Solution : Reader4 {
//     /**
//      * @param buf Destination buffer
//      * @param n   Number of characters to read
//      * @return    The number of actual characters read
//      */
//            private char[] read4buf = new char[4];
//         private int alreadyReadCount = 0;
//         private int alreadyReadIndex = 0;
//         bool endoffile = false;
//       public int Read(char[] buf, int n)
//         {
//             var readindex = 0;

//             if (alreadyReadCount > alreadyReadIndex)
//             {
//                 var length = Math.Min(n - readindex, alreadyReadCount - alreadyReadIndex);
//                 for (int i = 0; i < length; i++)
//                 {
//                     buf[i + readindex] = read4buf[i + alreadyReadIndex];
//                 }

//                 readindex = length;
//                 alreadyReadIndex += length;
//             }

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
//                 alreadyReadCount = readbytes;
//                 alreadyReadIndex = length;
//             }

//             return readindex;
//         }
// }