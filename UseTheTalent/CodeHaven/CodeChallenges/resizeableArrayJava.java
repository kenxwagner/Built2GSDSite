resizable array

class ResizableArray {

	private int[] items = new int[8];
	private int size = 0;

	public int size() {
		return size;
	}
	
	public void set (int index, int item) {
		if (index < 0 || index >= size) {
			throw new ArrayIndexOutOfBoundsException(index);
		}
		items[index] = item;
	}

	public void append(int item){
		giveExtraCapacity();
		items[size] = item;
		size++;
	
	}
	
	private void giveExtraCapacity() {
		if (size == items.length) {
			int[] copy = new int[size * 2];
			System.arraycopy(items, 0, copy, 0, size);
			items = copy;
		}
	}
	
	public int get (int index) {
		if(index < 0 || index >= size) {
			throw new ArrayIndexOutOfBoundsException(index);
		}
		return items[index];
	}


}