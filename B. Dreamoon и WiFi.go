package main

import (
	//"bytes"
	"fmt"
	//"strconv"
)

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
	//var f string

	var str, goal string
	//var buffer bytes.Buffer

	fmt.Scan(&goal)
	fmt.Scan(&str)

	pos, neg, g := 0, 0, 0

	var q uint

	for i := 0; i < len(str); i++ {
		if str[i] == '+' {
			pos++
		} else if str[i] == '-' {
			neg++
		} else {
			q++
		}

		if goal[i] == '+' {
			g++
		} else if goal[i] == '-' {
			g--
		}
	}

	total := 1 << q
	delta := pos - neg
	ans := 0

	for i := 0; i < total; i++ {
		val := 0

		for j := 0; j < q; j++ {
			if ((i >> uint(j)) & 1) > 0 {
				val++
			} else {
				val--
			}
		}

		if val+delta == g {
			ans++
		}
	}

	answ := float32(ans)
	answ /= float32(total)

	fmt.Printf("%.9f", answ)
}
