using System;

public class Program {
	public static int[] InsertionSort(int[] array){
        for(int i = 1; i < array.Length; i++){
            for(int j = i; j > 0; j--){
                bool swapped = false;
                if(array[j] < array[j-1]) {
                    swap(j,j-1, array);
                    swapped = true;
                }
                if(swapped == false) break;
            }
        }
		return array;
	}
    
    public static void swap(int i, int j, int[] arr){
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
}
