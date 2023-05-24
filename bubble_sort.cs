using System;

public class Program {
	public static int[] BubbleSort(int[] array) {
		bool sorted = true;
        for (int i = 0; i< array.Length; i++){
            for (int j = 0; j < array.Length - i - 1 ; j++){
                if (array[j] > array[j+1]){
                    int tmp = array[j+1];
                    array[j+1] = array[j];
                    array[j] = tmp;
                    sorted = false;
                }
            }
            if(sorted) break;
        }
		return array;
	}
}
