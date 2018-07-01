using System;

class Solution{
	public int Sum(int[]arr){
		int MaxSum = 0;
		int CurrentSum = 0;

		for (int i=0; i <arr.Length; i++){
			CurrentSum += arr[i];
			if (CurrentSum> MaxSum){
				MaxSum = CurrentSum;
			}
			if(CurrentSum < -1){
				CurrentSum = 0;
			}
		}

		return MaxSum;
	}

	static void Main(string [] args){
		int [] arr = new int []{1,5,-100,5,10,2,5};

		if(arr.Length ==0 || arr == null){
			Console.WriteLine("Array is empty");
		}
		else{
			Solution result = new Solution();
			Console.WriteLine(result.Sum(arr));
		}


	}
}