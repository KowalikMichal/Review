using System;

class Solution{

	public double Calculate(int n){
		double result = 1;

		if (n == 0){
			return result;
		}
		else{
			for (int value = 1; value < n; value++){
				result *= value;
			}
		return result;
		}


	}

	static void Main (string[] args){
		int n = 0;
		string userNumber = Console.ReadLine();
		bool convertNumber = Int32.TryParse(userNumber, out n);

		if (convertNumber){
			if (n <0 ){
				Console.WriteLine("n must by greater then 0");
			}
			else {
				Solution result = new Solution();
				Console.WriteLine(result.Calculate(n));
			}

		}
		else{
			Console.WriteLine("You don't type number");
		}
		

		
	}
}