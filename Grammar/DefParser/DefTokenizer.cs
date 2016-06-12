/*
 * DefTokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using PerCederberg.Grammatica.Runtime;

namespace InternalDSL {

    /**
     * <remarks>A character stream tokenizer.</remarks>
     */
    internal class DefTokenizer : Tokenizer {

        /**
         * <summary>Creates a new tokenizer for the specified input
         * stream.</summary>
         *
         * <param name='input'>the input stream to read</param>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        public DefTokenizer(TextReader input)
            : base(input, false) {

            CreatePatterns();
        }

        /**
         * <summary>Initializes the tokenizer by creating all the token
         * patterns.</summary>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        private void CreatePatterns() {
            TokenPattern  pattern;

            pattern = new TokenPattern((int) DefConstants.WHITESPACE,
                                       "WHITESPACE",
                                       TokenPattern.PatternType.REGEXP,
                                       "[ \\t\\n\\r]+");
            pattern.Ignore = true;
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.OPEN_TABLE,
                                       "OPEN_TABLE",
                                       TokenPattern.PatternType.STRING,
                                       "{");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.CLOSE_TABLE,
                                       "CLOSE_TABLE",
                                       TokenPattern.PatternType.STRING,
                                       "}");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.ASSIGN,
                                       "ASSIGN",
                                       TokenPattern.PatternType.STRING,
                                       "=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.DOT,
                                       "DOT",
                                       TokenPattern.PatternType.STRING,
                                       ".");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.DELIMITER,
                                       "DELIMITER",
                                       TokenPattern.PatternType.STRING,
                                       ",");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.OPEN_FUNCTION,
                                       "OPEN_FUNCTION",
                                       TokenPattern.PatternType.STRING,
                                       "(");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.CLOSE_FUNCTION,
                                       "CLOSE_FUNCTION",
                                       TokenPattern.PatternType.STRING,
                                       ")");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.NUMBER,
                                       "NUMBER",
                                       TokenPattern.PatternType.REGEXP,
                                       "[0-9]+");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.IDENTIFIER,
                                       "IDENTIFIER",
                                       TokenPattern.PatternType.REGEXP,
                                       "([a-z]|[A-Z]|_)+");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.STRING,
                                       "STRING",
                                       TokenPattern.PatternType.REGEXP,
                                       "[\\\"]([^\"\\\\]|\\\\.)*[\\\"]");
            AddPattern(pattern);

            pattern = new TokenPattern((int) DefConstants.DECLARATION,
                                       "DECLARATION",
                                       TokenPattern.PatternType.STRING,
                                       "as");
            AddPattern(pattern);
        }
    }
}
