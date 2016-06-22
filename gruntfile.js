/// <binding BeforeBuild='clean' AfterBuild='copy' />
module.exports = function (grunt) {
    //Configuration setup
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        copy: {
            domain: {
                expand: true,
                cwd: 'DexCMS.HelpDesk/bin/Release/',
                src: ['DexCMS.HelpDesk.dll'],
                dest: 'dist/'
            },
            //mvcHost: {
            //    expand: true,
            //    cwd: 'DexCMS.HelpDesk.Host.Mvc/bin/Release/',
            //    src: ['DexCMS.HelpDesk.Mvc.dll'],
            //    dest: 'dist/'
            //},
            //mvcClient: {
            //    expand: true,
            //    cwd: 'DexCMS.HelpDesk.Client.Mvc/bin/Release/',
            //    src: ['DexCMS.HelpDesk.Mvc.dll'],
            //    dest: 'dist/'
            //},
            webapiHost: {
                expand: true,
                cwd: 'DexCMS.HelpDesk.Host.WebApi/bin/Release/',
                src: ['DexCMS.HelpDesk.Host.WebApi.dll'],
                dest: 'dist/'
            },
            //webapiClient: {
            //    expand: true,
            //    cwd: 'DexCMS.HelpDesk.Client.WebApi/bin/Release/',
            //    src: ['DexCMS.HelpDesk.Client.WebApi.dll'],
            //    dest: 'dist/'
            //}
        },
        clean: {
            build: ["dist"]
        }
    });

    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-clean');

    grunt.registerTask('default', ['clean', 'copy']);
};
