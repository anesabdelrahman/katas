using System.Text;

namespace Katas.Strings
{
    public class KillerGarageDoor
    {
        public string ProcessEvents(string events)
        {
            //"P.............."
            //"123455555555555"
            var result = new StringBuilder();
            var opening = false;
            var currentItem = 0;

            for (var i = 0; i < events.Length; i++)
            {
                var item = events[i];


                switch (item)
                {
                    case 'P':
                        opening = !opening;

                        if (opening)
                            result.Append(++currentItem);
                        else
                            result.Append(--currentItem);

                        break;
                    case 'O':
                        if (item == 'P')
                        {
                            currentItem = 1;
                            result.Append(currentItem);

                        }
                        break;
                    case '.':
                        if (opening)
                            if (currentItem < 5)
                                result.Append(++currentItem);
                            else
                                result.Append(currentItem);
                        else
                            if (i > 0 && currentItem > 0)
                                result.Append(--currentItem);
                            else
                                result.Append("0");
                        break;
                }
            }
            return result.ToString();
        }
    }
}
