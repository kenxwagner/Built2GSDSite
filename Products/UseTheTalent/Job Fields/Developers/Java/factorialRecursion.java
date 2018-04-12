public static long fact(final int n) {
    if (n < 0){
        System.err.println("Negative numbers are not Allowed");
        return 0;
    }
    return (n < 2) ? 1 : n * fact(n - 1);
}