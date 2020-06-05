using System.Collections.Generic;
using System.Text;

namespace Arrays_String.LeetCode
{
    public class Expression_Add_Operators
    {
        public List<string> answer;
        public string digits;
        public long target;

        public IList<string> AddOperators(string num, int target)
        {

            if (num.Length == 0)
            {
                return new List<string>();
            }

            this.target = target;
            this.digits = num;
            this.answer = new List<string>();
            this.recurse(0, 0, 0, 0, new List<string>());
            return this.answer;
        }

        public void recurse(
               int index, long previousOperand, long currentOperand, long value, List<string> ops)
        {
            string nums = this.digits;

            // Done processing all the digits in num
            if (index == nums.Length)
            {

                // If the final value == target expected AND
                // no operand is left unprocessed
                if (value == this.target && currentOperand == 0)
                {
                    StringBuilder sb = new StringBuilder();
                    var range = ops.GetRange(1, ops.Count - 1);
                    foreach (var item in range)
                    {
                        sb.Append(item);
                    }
                    this.answer.Add(sb.ToString());
                }
                return;
            }

            // Extending the current operand by one digit
            currentOperand = currentOperand * 10 + long.Parse(nums[index].ToString());
            string current_val_rep = currentOperand.ToString();
            // int length = nums.Length;

            // To avoid cases where we have 1 + 05 or 1 * 05 since 05 won't be a
            // valid operand. Hence this check
            if (currentOperand > 0)
            {

                // NO OP recursion
                recurse(index + 1, previousOperand, currentOperand, value, ops);
            }

            // ADDITION
            ops.Add("+");
            ops.Add(current_val_rep);
            recurse(index + 1, currentOperand, 0, value + currentOperand, ops);
            ops.RemoveAt(ops.Count - 1);
            ops.RemoveAt(ops.Count - 1);

            if (ops.Count > 0)
            {

                // SUBTRACTION
                ops.Add("-");
                ops.Add(current_val_rep);
                recurse(index + 1, -currentOperand, 0, value - currentOperand, ops);
                ops.RemoveAt(ops.Count - 1);
                ops.RemoveAt(ops.Count - 1);

                // MULTIPLICATION
                ops.Add("*");
                ops.Add(current_val_rep);
                recurse(
                    index + 1,
                    currentOperand * previousOperand,
                    0,
                    value - previousOperand + (currentOperand * previousOperand),
                    ops);
                ops.RemoveAt(ops.Count - 1);
                ops.RemoveAt(ops.Count - 1);
            }
        }
    }
}