namespace dataAlgo {
    public class Sorting {
        public void BubbleSort (int[] array) {
            bool isSorted = false;
            for (var i = 0; i < array.Length; i++) {
                isSorted = true;
                for (int j = 1; j < array.Length - i; j++) {
                    if (array[j] < array[j - 1]) {
                        Swap (array, j, j - 1);
                        isSorted = false;
                    }
                    if (isSorted) return;
                }
            }
        }

        private void Swap (int[] array, int index, int index1) {
            var temp = array[index1];
            array[index1] = array[index];
            array[index] = temp;
        }
    }
}