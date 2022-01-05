#include <iostream>

extern "C" __declspec(dllexport) void HelloWorld();

void HelloWorld()
{
	std::cout << "Hello world! This is me in C++ land!";
}
