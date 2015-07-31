package main

import (
	"fmt"
)

func main() {
	var n, s, ans, f int
	fmt.Scan(&n)
	p := make([]int, n)
	for i := 0; i < n; i++ {
		fmt.Scan(&p[i])
		s += p[i]
	}

	for i := 1; i <= 5; i++ {
		if (s-1+i)%(n+1) == 0 {
			ans++
		}
	}

	fmt.Println(5 - ans)
	fmt.Scan(&f)
}
