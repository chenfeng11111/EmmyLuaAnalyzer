﻿using System.Diagnostics;
using LuaLanguageServer.CodeAnalysis.Kind;
using LuaLanguageServer.CodeAnalysis.Syntax.Node;
using LuaLanguageServer.CodeAnalysis.Syntax.Node.SyntaxNodes;
using LuaLanguageServer.CodeAnalysis.Syntax.Tree;

namespace LuaLanguageServer.CodeAnalysis.Compilation.Semantic;

public class SemanticModel
{
    private LuaCompilation _compilation;

    private LuaSyntaxTree _tree;

    public SemanticModel(LuaCompilation compilation, LuaSyntaxTree tree)
    {
        _compilation = compilation;
        _tree = tree;
    }

    public Symbol.Symbol GetSymbol(LuaSyntaxNodeOrToken nodeOrToken)
    {
        return nodeOrToken switch
        {
            LuaSyntaxNodeOrToken.Node node => GetSymbol(node),
            LuaSyntaxNodeOrToken.Token token => GetSymbol(token),
            _ => throw new UnreachableException()
        };
    }

    public Symbol.Symbol GetSymbol(LuaSyntaxNode node)
    {
        switch (node)
        {
            case LuaIndexExprSyntax indexExprSyntax:
            {
                break;
            }
            case LuaNameSyntax nameSyntax:
            {
                break;
            }
            default:
            {
                break;
            }
        }

        throw new NotImplementedException();
    }

    public Symbol.Symbol GetSymbol(LuaSyntaxToken token)
    {
        switch (token.Kind)
        {
            case LuaTokenKind.TkName:
            {
                break;
            }
            case LuaTokenKind.TkString:
            {
                break;
            }
            default:
            {
                break;
            }
        }

        throw new NotImplementedException();
    }
}