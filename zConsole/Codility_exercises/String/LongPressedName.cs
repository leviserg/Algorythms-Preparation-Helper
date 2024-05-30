namespace zConsole.Codility_exercises.String
{
    public static class LongPressedName
    {
        public static bool IsLongPressedName(string name, string typed)
        {

            int typedLength = typed.Length;
            int nameLength = name.Length;

            if (typedLength < nameLength) return false;
            int i = 0, j = 0;

            while (i < nameLength && j < typedLength) {
                char nameChar = name[i];
                char typedChar = typed[j];
                if(nameChar != typedChar) return false;

                int nameIndex = i + 1;
                int typedIndex = j + 1;

                while (nameIndex < nameLength && name[nameIndex] == nameChar) { 
                    ++nameIndex;
                }

                while (typedIndex < typedLength && typed[typedIndex] == typedChar)
                {
                    ++typedIndex;
                }

                if(typedIndex - j < nameIndex - i) return false;

                i = nameIndex;
                j = typedIndex;

            }

            return i >= nameLength && j >= typedLength;
        }

        public static bool IsLongPressedNameRefactor(string name, string typed)
        {
            int typedLength = typed.Length;
            int nameLength = name.Length;

            if (typedLength < nameLength)
                return false;

            int i = 0;

            for (int j = 0; j < typedLength; j++)
            {
                if (i < nameLength && name[i] == typed[j])
                {
                    i++;
                }
                else if (j == 0 || typed[j - 1] != typed[j])
                    return false;
            }


            return i == nameLength;
        }
    }
}
