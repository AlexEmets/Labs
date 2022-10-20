package lab3;

import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

class CPPTokenizer {
    public static final String DECIMAL_LITERAL = "\\d+(u|U)?(l|L)?";

    public static final String FLOAT_LITERAL = "\\d+\\.\\d*";

    public static final String CHAR_LITERAL = "'.'";

    public static final String STRING_LITERAL = "\".+\"";

    public static final String ONE_LINE_COMMENT = "\\/\\/.*";

    public static final String MULTIPLE_LINE_COMMENT = "\\/\\*(.|\\n)*\\*\\/";

    public static final String KEYWORDS = "\\b(auto|double|int|struct|break|else|long|switch" +
            "|case|enum|register|typedef|char|extern|return|union|continue|for|signed|void|do|if|static|while|default|goto" +
            "|sizeof|volatile|const|float|short|unsigned)\\b";

    public static final String IDENTIFIER = "\\b[_A-Za-z][0-9A-Za-z_]*\\b";

    public static final String OPERATORS = "\\.|->|\\+\\+|--|&|\\*|\\+|-|~|!|/|%|<<|>>|<|>|<=|>=|==|!=|&&|\\|\\||\\?|:|=|\\*=|/=|%=|\\+=|-=|<<=|>>=|&=|\\^=";

    public static final String PUNCTUATORS = "\\{|\\}|,|;|\\(|\\)|[|]";

    public static final String PREPROC_DIRECTIVE = "#";

    private List<PatternWithName> patterns = new ArrayList<PatternWithName>();

    public CPPTokenizer() {
        patterns = new ArrayList<>();
        patterns.add(new PatternWithName(Pattern.compile(DECIMAL_LITERAL), "decimal literal"));
        patterns.add(new PatternWithName(Pattern.compile(FLOAT_LITERAL), "hex literal"));
        patterns.add(new PatternWithName(Pattern.compile(CHAR_LITERAL), "char literal"));
        patterns.add(new PatternWithName(Pattern.compile(STRING_LITERAL), "String Literal"));
        patterns.add(new PatternWithName(Pattern.compile(ONE_LINE_COMMENT), "one line comment"));
        patterns.add(new PatternWithName(Pattern.compile(MULTIPLE_LINE_COMMENT), "multiple line comment"));
        patterns.add(new PatternWithName(Pattern.compile(KEYWORDS), "C keyword"));
        patterns.add(new PatternWithName(Pattern.compile(IDENTIFIER), "identifier"));
        patterns.add(new PatternWithName(Pattern.compile(OPERATORS), "operator"));
        patterns.add(new PatternWithName(Pattern.compile(PUNCTUATORS), "punctuator"));
        patterns.add(new PatternWithName(Pattern.compile(PREPROC_DIRECTIVE), "preprocessor directive"));
    }

    public void AutomaticTokenizeAndPrint(String code) {

        List<Token> tokens = new ArrayList<>();
        boolean[] matched = new boolean[code.length()];

        for (PatternWithName pattern : patterns) {
            Matcher m = pattern.pattern.matcher(code);
            while (m.find()) {
                if (match(matched, m.start(), m.end() - 1)) {
                    tokens.add(new Token(m.start(), m.group(0), pattern.name));
                }
            }
        }

        tokens.sort(Comparator.comparingInt(t -> t.start));
        tokens.forEach(token -> System.out.println(token.value + " - " + token.type));
    }

    private static boolean match(boolean[] matched, int l, int r) {
        assert l <= r;
        for (int i = l; i <= r; i++) {
            if (matched[i]) {
                return false;
            }
            matched[i] = true;
        }
        return true;
    }

    record PatternWithName(Pattern pattern, String name) {
    }

    record Token(Integer start, String value, String type) {
    }

}

public class Main {
    private static final String PATH_1= "test1.c";
    private static final String PATH_2 = "test2.c";

    public static void main(String[] args) {
        String code;
        try {
            code = Files.readString(Paths.get(PATH_2), StandardCharsets.US_ASCII);
        } catch (IOException e) {
            e.printStackTrace();
            return;
        }
       // System.out.println(code);
        CPPTokenizer tokenizer = new CPPTokenizer();
        tokenizer.AutomaticTokenizeAndPrint(code);
        System.out.println(CPPTokenizer.KEYWORDS);
    }

}
