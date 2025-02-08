
集合类型	           最佳使用场景	                       性能特点
List<T>	           需要索引访问、频繁添加/删除末端元素	   插入末端O(1)，中间插入O(n)
Dictionary<K,V>	   快速键值查找、唯一键存储	             查找/插入/删除平均O(1)
HashSet<T>	       唯一元素存储、集合运算	               存在性检查O(1)
Queue<T>	         先进先出处理（如任务队列）	           Enqueue/Dequeue均为O(1)
Stack<T>	         后进先出处理（如撤销操作）	           Push/Pop均为O(1)
