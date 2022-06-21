package main

import (
	"fmt"
	"math"
)

func constantsPackage() {
	fmt.Println("======================")
	// Constants
	fmt.Println(s)
	
	const m = 500000000

	const n = 3e20 / m
	fmt.Println(n)

	fmt.Println(int64(n))

	fmt.Println(math.Sin(m))
}