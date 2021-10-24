#cmake file to build unit tests for ExcelQMake project (../)
cmake_minimum_required(VERSION 3.10)
project(projectTests)

set(SOURCES
        tests.cpp
        )

add_executable(projectTests ${SOURCES})

target_link_libraries(projectTests PUBLIC
        gtest
        gtest_main
        project
        )

add_test(
        NAME projectTests
        COMMAND projectTests
)
