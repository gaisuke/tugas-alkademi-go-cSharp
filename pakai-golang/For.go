package main

import "fmt"

func forPackage() {
	fmt.Println("======================")
	// For
	i := 1
	for i <= 3 {
		fmt.Println(i)
		i = i + 1
	}
	for j := 7; j <= 9; j++ {
		fmt.Println(j)
	}
	for {
		fmt.Println("loop")
		break
	}
	for s := 0; s <= 5; s++ {
		if s%2 == 0 {
			continue
		}
		fmt.Println(s)
	}
}