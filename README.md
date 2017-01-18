# Weekdays
Indexing the weekdays 
#Keywords
C# 6.0, .Net Framework 4.6, Microsoft Visual Studio.

In **Weekdays** repository you can find **Weekdays class**, where by using indexer method weekdays were indexed from 0-6.
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
 
 <img src="https://cloud.githubusercontent.com/assets/24455176/21984295/b7138528-dc0e-11e6-8d76-3985ad86f8b8.png" align="left"  />
 
