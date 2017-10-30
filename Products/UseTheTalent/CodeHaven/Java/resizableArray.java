public class ResizableArray {
	private int[] items = new int[8];
	private int size = 0;
	
	public int size(0 {
		return size;
		)
		
		public void set(int index, int item) {
			if (index < 0 || index >= size) {
				throw new ArrayIndexOutOfBoundsException(index);
			}
			items[index] = item;
		}
		
		public void append(int item) {
			ensureExtraCapacity();
			items[size] = item;
			size++;
		
		}
		
		private void ensureExtraCapacity() {
			if (size == items.length) {
				int[] copy = new int[size * 2];
				System.arraycopy(items, 0, copy, 0, size);
			}
		}
}