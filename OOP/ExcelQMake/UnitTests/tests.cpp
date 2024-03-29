#include"gtest/gtest.h"
#include"../parser.h"
TEST(test1, aboba) {

    Parser parser;
    std::string testedExpression = "2+3*4";
    double expectedResult = 14;
    double resultOfParserClass = parser.calculateExpression(testedExpression);
    EXPECT_EQ(resultOfParserClass, expectedResult);

}

TEST(test2, aboba) {

    Parser parser;
    std::string testedExpression = "2*2+(2+3^2)";
    int expectedResult = 15;
    double resultOfParserClass = parser.calculateExpression(testedExpression);
    EXPECT_EQ(resultOfParserClass, expectedResult);

}

TEST(test3, aboba) {

    Parser parser;
    std::string testedExpression = "(3+3)^(8-5*(1+4-2*2))";
    int expectedResult = 216;
    double resultOfParserClass = parser.calculateExpression(testedExpression);
    EXPECT_EQ(resultOfParserClass, expectedResult);

}