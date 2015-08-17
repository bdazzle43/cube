package main

import (
	// "image/draw"
	"image/jpeg"
	"image/png"
	"log"
	"os"
)

func testJpegToPng() {
	file, err := os.Open("demo.jpg")
	if err != nil {
		log.Fatalln(err)
	}
	defer file.Close()

	img, err := jpeg.Decode(file)
	if err != nil {
		log.Fatalln(err)
	}

	desFile, err := os.Create("demo.png")
	if err != nil {
		log.Fatalln(err)
	}
	defer desFile.Close()

	png.Encode(desFile, img)
}

func testResize() {

	file, err := os.Open("demo.jpg")
	if err != nil {
		log.Fatalln(err)
	}
	defer file.Close()

	img, err := jpeg.Decode(file)
	if err != nil {
		log.Fatalln(err)
	}

	// desFile, err := os.Create("demo_resize.jpg")
	// if err != nil {
	// 	log.Fatalln(err)
	// }
	// defer desFile.Close()

	bounds := img.Bounds()
	log.Println(bounds.Size())
}

func main() {
	log.Println("START")
	// testJpegToPng()
	testResize()
}
