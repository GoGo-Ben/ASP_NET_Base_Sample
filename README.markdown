###Name:BIG5_To_Unicode_UTF8    
Tool:Visual studio 2015 Community    
範例是中文轉成Big5，再轉成UTF8，中文變"嚙踝蕭嚙踝蕭"的原因  
參考解法：http://blog.darkthread.net/post-2016-10-10-utf8-big5-encoding-ef-bf-bd-issue.aspx  

---
###Name:Enum_ParameterDefaultValue    
Tool:Visual studio 2015 Community    
範例是列舉Enum，字串轉數字、或數字轉字串    

---
###Name:Two-dimensional_Arrays_to_Json    
Tool:Visual studio 2015  
原始資料是Table，資料是同一天，會有多筆資料    

| 日期       | StartTime | EndTime |
|------------|-----------|---------|
| 2016/06/19 | 1         | 5       |
| 2016/06/19 | 10        | 15      |
|            |           |         |
需求是要將同一天的資料轉成Json格式	[["1","5"],["10,"15"]],  
做法請查看此範例二維陣列轉Json  
