pipeline {
    agent any

    stages {
        stage('Primeiro Stage') {
            steps {
                git url:'https://github.com/ivrcode/Gsn_reclameali.git', branch: 'main'
            }
        }

        stage('Constrindo image Docker') {
            steps {
                dockerapp = docker.build("isrcode/gsn:${env.BUILD_ID}",
                                        '-f ./Gsn_reclameali/Gsn-ReclameAli/Dockerfile ./Gsn_reclameali/Gsn-ReclameAli')
                                        
            }
        }
    }
}
