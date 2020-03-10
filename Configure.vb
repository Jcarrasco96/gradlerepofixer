Module Configure

    Public pathProject As String = ""
    Public pathGradle As String = ""

    Function configureUCF(ByVal version As String) As Boolean
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "buildscript {" & vbCrLf, False)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    repositories {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://nexus.ucf.edu.cu/repository/maven-public/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    dependencies {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        classpath 'com.android.tools.build:gradle:" & version & "'" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "allprojects {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    repositories {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://nexus.ucf.edu.cu/repository/maven-public/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "task clean(type: Delete) {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    delete rootProject.buildDir" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf, True)

        createGWP()

        Return True
    End Function

    Function configureUCI(ByVal version As String) As Boolean
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "buildscript {" & vbCrLf, False)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    repositories {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://pypi.prod.uci.cu/repository/maven-all/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://pypi.prod.uci.cu/repository/jitpack.io/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://pypi.prod.uci.cu/repository/jcenter/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    dependencies {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        classpath 'com.android.tools.build:gradle:" & version & "'" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "allprojects {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    repositories {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://pypi.prod.uci.cu/repository/maven-all/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://pypi.prod.uci.cu/repository/jitpack.io/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""http://pypi.prod.uci.cu/repository/jcenter/"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "task clean(type: Delete) {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    delete rootProject.buildDir" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf, True)

        createGWP()

        Return True
    End Function

    Function configureGOOGLE(ByVal version As String) As Boolean
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "buildscript {" & vbCrLf, False)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    repositories {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        google()" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        jcenter()" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        mavenCentral()" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""https://jitpack.io"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    dependencies {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        classpath 'com.android.tools.build:gradle:" & version & "'" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "allprojects {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    repositories {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        google()" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        jcenter()" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        mavenCentral()" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "        maven { url ""https://jitpack.io"" }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    }" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf & vbCrLf, True)

        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "task clean(type: Delete) {" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "    delete rootProject.buildDir" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "build.gradle", "}" & vbCrLf, True)

        createGWP()

        Return True
    End Function

    Function createGWP() As Boolean
        My.Computer.FileSystem.CreateDirectory(pathProject & "gradle\wrapper\")
        My.Computer.FileSystem.WriteAllText(pathProject & "gradle\wrapper\gradle-wrapper.properties", "distributionBase=GRADLE_USER_HOME" & vbCrLf, False)
        My.Computer.FileSystem.WriteAllText(pathProject & "gradle\wrapper\gradle-wrapper.properties", "distributionPath=wrapper/dists" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "gradle\wrapper\gradle-wrapper.properties", "zipStoreBase=GRADLE_USER_HOME" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "gradle\wrapper\gradle-wrapper.properties", "zipStorePath=wrapper/dists" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(pathProject & "gradle\wrapper\gradle-wrapper.properties", "distributionUrl=file\:/" & pathGradle.Replace("\", "/") & vbCrLf, True)
        Return True
    End Function

End Module
