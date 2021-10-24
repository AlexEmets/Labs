#cmake file to build unit tests for ExcelQMake project (../)
cmake_minimum_required(VERSION 3.10)
project(projectTests)
ADD_SUBDIRECTORY (googletest)
include_directories(${gtest_SOURCE_DIR}/include ${gtest_SOURCE_DIR})

add_executable(runUnitTests tests.cpp)
add_executable(source ../parser.cpp)

target_link_libraries(runUnitTests gtest gtest_main)
add_test( runUnitTests runUnitTests )