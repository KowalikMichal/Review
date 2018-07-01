using System;
class Solution{
	public bool FindNumber(int [] arr){
		int target = -1;
		bool returnValue = false;

		foreach(int value in arr){
			if(value == target){
				returnValue =  true;
				break;
			}
		}
		return returnValue;
	}

	static void Main(string [] args){
		int [] arr = new int []{2,1,4,5,-1};

		if(arr == null || arr.Length == 0){
			Console.WriteLine("Array is empty");
		}
		else{
			Solution result = new Solution();
			Console.WriteLine(result.FindNumber(arr));
		}
		
	}
}

using System;
class Solution{
	static void Main(string [] args){
		int [] arr = new int []{2,1,4,5,-1};
		int target = -1;

		if(arr == null || arr.Length == 0){
			Console.WriteLine("Array is empty");
		}
		else{
			int x = Array.IndexOf(arr, target);

			if (x != -1){
				Console.WriteLine("true");
			}
			else{
				Console.WriteLine("false");
			}

		}
		
	}
}