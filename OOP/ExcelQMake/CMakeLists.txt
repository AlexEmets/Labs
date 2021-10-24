cmake_minimum_required(VERSION 3.10)
project(project)

enable_testing()

add_subdirectory (googletest)

include_directories(${gtest_SOURCE_DIR}/include ${gtest_SOURCE_DIR})

set(HEADERS
    parser.h
    )

set(SOURCES
    parser.cpp
    )

add_library(project STATIC ${SOURCES} ${HEADERS})

add_subdirectory(UnitTests)
