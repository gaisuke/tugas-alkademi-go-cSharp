package main

import "fmt"

func variablesPackage() {
	fmt.Println("======================")
	// Variables
	var a = "initial"
	fmt.Println(a)

	var b, c int = 1, 2
	fmt.Println(b, c)

	var d = true
	fmt.Println(d)

	var e int
	fmt.Println(e)

	f := "apple"
	fmt.Println(f)

	g := [5]int{2,4,5,3,6}
	fmt.Println("array :", g)
}