namespace dataAlgo {
    public class Sorting {
        public int[] BubbleSort (int[] array) {
            for (var i = 0; i < array.Length; i++)
                if (array[i] > array[i + 1]) {
                    var temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;

                }
            return array;
        }
    }
}