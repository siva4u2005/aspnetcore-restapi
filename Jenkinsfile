pipeline {
 agent any
  stages {
   stage('Restore PACKAGES') {
   steps {
    bat "dotnet restore"
   }
  }
  stage('Clean') {
   steps {
    bat 'dotnet clean'
   }
  }
  stage('Build') {
   steps {
    bat 'dotnet build -c release'
   }
  }
  stage('Publish') {
   steps {
    bat 'dotnet publish -c release --no-build --no-restore -o Deploy'
   }
  }
  
 }
}