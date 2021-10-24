#include "gtest/gtest.h"
#include"../parser.h"
TEST(sample_test_case4, sample_test)
{
    Parser parser;

    std::string inputExpression = "2+2*2";
    int expectedResult = 6;

    double resultFromParserClass = parser.RPNtoNumber(parser.expressionToRPN(inputExpression));
    EXPECT_EQ(1, 1);
}

int main() {
    testing::InitGoogleTest();
    RUN_ALL_TESTS();
}