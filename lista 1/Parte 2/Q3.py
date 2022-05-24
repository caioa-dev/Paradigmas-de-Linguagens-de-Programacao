def func1():
    def foo():
        L = []

        def bar():
            L.append(5)

        bar()
        return L

    foo()


def func2():
    def foo():
        def bar():
            L.append(5)

        L = []
        bar()
        return L

    foo()


def func3():
    def foo():
        L = []
        bar()
        return L

    def bar():
        L.append(5)

    foo()


def main():
    try:
        func1()
    except BaseException as bs:
        print("Erro na func1: ", bs)
    else:
        print("Sucesso!")

    try:
        func2()
    except BaseException as bs:
        print("Erro na func2: ", bs)
    else:
        print("Sucesso!")

    try:
        func3()
    except BaseException as bs:
        print("Erro na func3: ", bs)
    else:
        print("Sucesso!")

main()
