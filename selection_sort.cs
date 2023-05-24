using System;

public class Program {
	public static int[] SelectionSort(int[] array) {
        int smallestPlace = 0;
        for(int pivot = 0; pivot < array.Length; pivot++){
            for(int j = pivot; j < array.Length; j++){;
                if(array[j] < array[smallestPlace]) smallestPlace = j;
            }
            swap(pivot, smallestPlace, array);
            smallestPlace = pivot + 1;
        }
        
		return array;
	}
    public static void swap(int i, int j, int[] arr){
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}