package main

import (
	//"bytes"
	"fmt"
	//"strconv"
)

/*func main() {

	var n, x, y int
	a, b, c := 0, 0, 0
	fmt.Scan(&n)
	for i := 0; i < n; i++ {
		fmt.Scan(&x, &y)
		a += x
		b += y
		if x%2 != y%2 {
			c++
		}
	}
	if a%2 == 0 && b%2 == 0 {
		fmt.Print("0")
	} else if c%2 == 0 && c > 0 {
		fmt.Print("1")
	} else {
		fmt.Print("-1")
	}
}*/

func Max(n int, g int) int {
	if n > g {
		return n
	} else {
		return g
	}
}

func Min(n int, g int) int {
	if n > g {
		return g
	} else {
		return n
	}
}

func main() {

	var n, g, f, ans int
	//var buffer bytes.Buffer

	fmt.Scan(&n, &g)

	if n < g {
		max := Max(n, g)
		min := Min(n, g)

		for max > min {
			if max%2 == 0 {
				max /= 2
			} else {
				max++
			}
			ans++
			//buffer.WriteString(fmt.Sprint(strconv.Itoa(max), strconv.Itoa(min)))
			//println(buffer.String())
		}

		if max == min {
			fmt.Println(ans)
		} else {
			ans += min - max
			fmt.Println(ans)
		}
	} else {
		ans += n - g
		fmt.Println(ans)
	}
	fmt.Scan(&f)

}
