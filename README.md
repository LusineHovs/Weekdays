# Weekdays
Indexing the weekdays (C# 6.0)

In **Weekdays** repository you can find **Weekdays class*, where by using indexer method weekdays were indexed from 0-6.
```C#
public string this[int index]
        {
            get
            {
                if (index > weekdays.Length && index<0)
                    throw new IndexOutOfRangeException();
                return weekdays[index];
            }
        }
 ```
 
 The **Output** of executable file is the following
 
- The 1st day of the week is Sunday
- The 2st day of the week is Monday
- The 3st day of the week is Tuesday
- The 4st day of the week is Wednesday
- The 5st day of the week is Thursday
- The 6st day of the week is Friday
- The 7st day of the week is Saturday
