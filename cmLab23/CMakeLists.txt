cmake_minimum_required(VERSION 3.20)
project(Sanya)

set(CMAKE_CXX_STANDARD 14)

add_executable(Sanya main.cpp Shooting.cpp Shooting.h RungeKutta.cpp RungeKutta.h)
