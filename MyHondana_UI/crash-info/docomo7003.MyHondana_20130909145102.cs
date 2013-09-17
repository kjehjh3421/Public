S/W Version Information
Model: SGH-N099
Tizen-Version: 2.2.0
Build-Number: N099OMEAMI1
Build-Date: 2013.09.03 00:50:52

Crash Information
Process Name: MyHondana
PID: 18344
Date: 2013-09-09 14:51:02(GMT+0900)
Executable File Path: /opt/apps/docomo7003/bin/MyHondana
This process is multi-thread process
pid=18344 tid=18344
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18344, uid 5000)

Register Information
r0   = 0xa5364048, r1   = 0x00000001
r2   = 0xbe8570a0, r3   = 0x00000000
r4   = 0xa343f628, r5   = 0x00000002
r6   = 0xa343f628, r7   = 0xb48ee244
r8   = 0xbe8570a0, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb621d294
ip   = 0xb6f50b98, sp   = 0xbe8570a0
lr   = 0xb47d3987, pc   = 0xb47d3960
cpsr = 0x68070030

Memory Information
MemTotal:  1895820 KB
MemFree:    420428 KB
Buffers:    116956 KB
Cached:     761640 KB
VmPeak:     363956 KB
VmSize:     241500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:      159000 KB
VmRSS:      159000 KB
VmData:     130136 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       73868 KB
VmPTE:         348 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
01816000 018c0000 rw-p [heap]
018c0000 034d0000 rw-p [heap]
a2c16000 a2d8b000 rw-s anon_inode:dmabuf
a2d8b000 a2f00000 rw-s anon_inode:dmabuf
a398a000 a3d22000 rw-s anon_inode:dmabuf
a3d22000 a40ba000 rw-s anon_inode:dmabuf
a47aa000 a4b42000 rw-s anon_inode:dmabuf
a583e000 a59b3000 rw-s anon_inode:dmabuf
a5e0a000 a5f7f000 rw-s anon_inode:dmabuf
a760a000 a777f000 rw-s anon_inode:dmabuf
a7999000 a7b0e000 rw-s anon_inode:dmabuf
a8ab9000 a8c2e000 rw-s anon_inode:dmabuf
a8ec3000 a9038000 rw-s anon_inode:dmabuf
aa5f7000 aa76c000 rw-s anon_inode:dmabuf
aaaf3000 aac68000 rw-s anon_inode:dmabuf
ad2ce000 ad44c000 rw-s anon_inode:dmabuf
ad44c000 ad5ca000 rw-s anon_inode:dmabuf
adae8000 ade80000 rw-s anon_inode:dmabuf
ae852000 aebea000 rw-s anon_inode:dmabuf
af620000 af622000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
afb8e000 b038d000 rwxp [stack:18346]
b0583000 b05a5000 r-xp /usr/lib/egl/libEGL.so
b05ae000 b05d7000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b05e3000 b0601000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b093b000 b0987000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b0990000 b0995000 r-xp /usr/lib/libjson.so.0.0.1
b099d000 b09a0000 r-xp /usr/lib/liblocation-pos-log.so
b09a8000 b09ba000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b09c2000 b09c4000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b09cc000 b09d1000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b09da000 b09e4000 r-xp /usr/lib/libdrm-trusted.so.0.0.54
b09ed000 b09ef000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b09f7000 b0a04000 r-xp /usr/lib/libdrm-client.so.0.0.93
b0a0c000 b0a0f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b0a17000 b0a4f000 r-xp /usr/lib/libpulse.so.0.16.2
b0a50000 b0ab4000 r-xp /usr/lib/libasound.so.2.0.0
b0abe000 b0ac1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b0aca000 b0ace000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b0ad7000 b0aee000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b0af7000 b0afc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b0b04000 b0b0a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b0b12000 b0b41000 r-xp /usr/lib/libSLP-location.so.0.0.0
b0b49000 b0b51000 r-xp /usr/lib/libdownload-provider-interface.so.1.1.0
b0b59000 b0b5d000 r-xp /usr/lib/libmmffile.so.0.0.0
b0b66000 b0b6d000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b0b76000 b0b8f000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b0b98000 b0bb3000 r-xp /usr/lib/libmedia-service.so.1.0.0
b0bbc000 b0bc7000 r-xp /usr/lib/libmdm-common.so.1.0.42
b0bcf000 b0bdb000 r-xp /usr/lib/libbookmark-adaptor.so.1.3.5
b0be3000 b0bea000 r-xp /usr/lib/libenchant.so.1.6.1
b0bf2000 b0bf6000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.10
b0bfe000 b0c07000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b0c10000 b0c15000 r-xp /usr/lib/libmmfsession.so.0.0.0
b0c1d000 b0c2b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b0c33000 b0c38000 r-xp /usr/lib/libmemenv.so.1.1.0
b0c40000 b0c7e000 r-xp /usr/lib/libleveldb.so.1.1.0
b0c87000 b0cb1000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b0cba000 b0cbc000 r-xp /usr/lib/libsecfw.so
b0cc4000 b0ccd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b0cd8000 b0ce7000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b0cef000 b0d07000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b0d09000 b0d16000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b0d1f000 b0d28000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b0d30000 b0d73000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b0d7b000 b0e17000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b0e23000 b0e48000 r-xp /usr/lib/libxslt.so.1.1.16
b0e51000 b0e53000 r-xp /usr/lib/libewebkit2-ext.so.1.0.3
b0e5b000 b0e64000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b0e6c000 b0e78000 r-xp /usr/lib/libcapi-location-manager.so.0.2.0
b0e81000 b0e84000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b0e8c000 b0eac000 r-xp /usr/lib/osp/libosp-locations.so.1.2.2.2
b0ead000 b0eb1000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b0eb9000 b0ee2000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.79
b0eea000 b0f27000 r-xp /usr/lib/libmdm.so.1.0.71
b0f2f000 b0f33000 r-xp /usr/lib/libss-client.so.1.0.0
b0f3c000 b0f4f000 r-xp /usr/lib/libnetwork.so.0.0.0
b0f57000 b0f5f000 r-xp /usr/lib/libcapi-web-favorites.so
b0f67000 b219e000 r-xp /usr/lib/libewebkit2.so.0.10.174.3
b2286000 b22e0000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b22ea000 b2302000 r-xp /usr/lib/libwifi-direct.so.0.0
b230a000 b2315000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b231d000 b2327000 r-xp /usr/lib/libcapi-network-connection.so.0.1.16
b2330000 b23a4000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b23b2000 b2477000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2485000 b249f000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b24a9000 b24c7000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b24d1000 b24d3000 r-xp /usr/lib/bufmgr/libtbm_msm8974.so.0.0.0
b24db000 b24e5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b24ed000 b255d000 r-xp /opt/usr/apps/docomo7003/bin/MyHondana.exe
b2569000 b25e5000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b25ed000 b25ef000 r-xp /usr/lib/libxcb-shape.so.0.0.0
b25f7000 b25fb000 r-xp /usr/lib/libxcb-xfixes.so.0.0.0
b2603000 b2606000 r-xp /usr/lib/libxcb-dri2.so.0.0.0
b260e000 b260f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b261f000 b2621000 r-xp /opt/usr/apps/docomo7003/bin/MyHondana
b2629000 b262c000 r-xp /usr/lib/libc2d2.so
b2634000 b2636000 r-xp /usr/lib/libadreno_utils.so
b2640000 b2d84000 r-xp /usr/lib/egl/libGLESv2.so
b2dc2000 b2dd6000 r-xp /usr/lib/libgsl.so
b2ddf000 b2e1a000 r-xp /usr/lib/egl/libGLES_CM.so
b2e24000 b2ee3000 r-xp /usr/lib/libCOREGL.so.3.0
b2eee000 b2ef1000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2ef9000 b2f00000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2f09000 b2f18000 r-xp /usr/lib/libICE.so.6.3.0
b2f22000 b2f27000 r-xp /usr/lib/libSM.so.6.0.1
b2f2f000 b2f30000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2f38000 b2f3a000 r-xp /usr/lib/libledplayer.so.0.1
b2f42000 b2f48000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2f50000 b2f51000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2f5a000 b2f61000 r-xp /usr/lib/libGLESv2.so.2.0
b2f69000 b2fb0000 r-xp /usr/lib/libtiff.so.5.1.0
b2fbb000 b2fe4000 r-xp /usr/lib/libturbojpeg.so
b2ffd000 b3001000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b300a000 b3010000 r-xp /usr/lib/libgif.so.4.1.6
b3018000 b303a000 r-xp /usr/lib/libavutil.so.51.73.101
b3049000 b3077000 r-xp /usr/lib/libswscale.so.2.1.101
b3080000 b3377000 r-xp /usr/lib/libavcodec.so.54.59.100
b369e000 b36b7000 r-xp /usr/lib/libpng12.so.0.50.0
b36c0000 b36c8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36d0000 b36d4000 r-xp /usr/lib/libtbm.so.1.0.0
b36dc000 b36e4000 r-xp /usr/lib/libdrm.so.2.4.0
b36ec000 b36ee000 r-xp /usr/lib/libdri2.so.0.0.0
b36f6000 b36fd000 r-xp /usr/lib/libfeedback.so.0.1.4
b3709000 b371d000 r-xp /usr/lib/libtts.so
b3725000 b3727000 r-xp /usr/lib/libEGL.so.1.4
b372f000 b37e6000 r-xp /usr/lib/libcairo.so.2.11200.12
b37f0000 b380a000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3812000 b40f5000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b4167000 b416f000 r-xp /usr/lib/libslp_devman_plugin.so
b4177000 b4190000 r-xp /usr/lib/liblzma.so.5.0.3
b4198000 b419e000 r-xp /usr/lib/libsystemd-id128.so.0.0.24
b41a7000 b41be000 r-xp /usr/lib/libsystemd-journal.so.0.11.1
b41c7000 b41c8000 r-xp /usr/lib/liblogd.so
b41d0000 b41e5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b41ed000 b41ef000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41f7000 b41fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4202000 b4205000 r-xp /usr/lib/libdevice-node.so.0.1
b420d000 b425f000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b4269000 b4276000 r-xp /usr/lib/libaccounts-svc.so.0.2.77
b427f000 b4282000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b428a000 b428e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4296000 b429c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b42a4000 b42a5000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b42ae000 b42b1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b42b9000 b42bc000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b42c5000 b42c8000 r-xp /usr/lib/libcapi-network-serial.so.0.0.9
b42d0000 b42d1000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b42d9000 b42e7000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.1
b42f0000 b4316000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b431e000 b4321000 r-xp /usr/lib/libuuid.so.1.3.0
b432a000 b4347000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b434f000 b4366000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b436f000 b4370000 r-xp /usr/lib/libpmapi.so.1.2
b4378000 b4380000 r-xp /usr/lib/libminizip.so.1.0.0
b4388000 b4392000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b439b000 b43b9000 r-xp /usr/lib/libpcre.so.0.0.1
b43c1000 b43c4000 r-xp /usr/lib/libiniparser.so.0
b43cd000 b44ed000 r-xp /usr/lib/libicui18n.so.48.1
b44fb000 b4502000 r-xp /usr/lib/libbadge.so.0.0.1
b450a000 b450d000 r-xp /usr/lib/libheynoti.so.0.0.2
b4515000 b4525000 r-xp /usr/lib/libdeviced.so.0.1.0
b452d000 b4538000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b4545000 b454b000 r-xp /usr/lib/libdevman.so.0.1
b4553000 b4557000 r-xp /usr/lib/libchromium.so.1.0
b455f000 b4565000 r-xp /usr/lib/libappsvc.so.0.1.0
b456d000 b456e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b4576000 b457d000 r-xp /usr/lib/libalarm.so.0.0.0
b4585000 b458f000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4598000 b45a9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b45b2000 b45b5000 r-xp /usr/lib/osp/libosp-newlib.so.1.2.2.1
b45bd000 b48c7000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b48ef000 b48f9000 r-xp /lib/libnss_files-2.13.so
b4902000 b4913000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b491b000 b491d000 r-xp /usr/lib/libsystemd-daemon.so.0.0.10
b4926000 b4937000 r-xp /usr/lib/libcom-core.so.0.0.1
b493f000 b4942000 r-xp /usr/lib/libXv.so.1.0.0
b494a000 b495f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4968000 b4a33000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4a49000 b4a59000 r-xp /usr/lib/libnotification.so.0.1.0
b4a61000 b4a67000 r-xp /usr/lib/libutilX.so.1.1.0
b4a6f000 b4a92000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4a9c000 b4b74000 r-xp /usr/lib/libxml2.so.2.7.8
b4b81000 b4b91000 r-xp /lib/libresolv-2.13.so
b4b95000 b4b97000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4b9f000 b4c3a000 r-xp /usr/lib/libstdc++.so.6.0.14
b4c4d000 b4c5c000 r-xp /usr/lib/libsf_common.so
b4c64000 b4c67000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4c6f000 b4d4c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4d57000 b4d5c000 r-xp /usr/lib/libcheck.so.0.0.0
b4d64000 b4d6e000 r-xp /usr/lib/libspdy.so.0.0.0
b4d77000 b4ecb000 r-xp /usr/lib/libcrypto.so.1.0.0
b4ee9000 b4f37000 r-xp /usr/lib/libssl.so.1.0.0
b4f43000 b4f71000 r-xp /usr/lib/libidn.so.11.5.44
b4f7a000 b4f84000 r-xp /usr/lib/libcares.so.2.1.0
b4f8c000 b4fa3000 r-xp /lib/libexpat.so.1.5.2
b5fa2000 b608a000 r-xp /usr/lib/libicuuc.so.48.1
b6097000 b60bb000 r-xp /usr/lib/libicule.so.48.1
b60c4000 b60e7000 r-xp /usr/lib/libexif.so.12.3.3
b60fb000 b6105000 r-xp /usr/lib/libethumb.so.1.7.99
b610d000 b6151000 r-xp /usr/lib/libsndfile.so.1.0.25
b615f000 b6161000 r-xp /usr/lib/libctxdata.so.0.0.0
b6169000 b6177000 r-xp /usr/lib/libremix.so.0.0.0
b617f000 b6180000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6188000 b61a1000 r-xp /usr/lib/liblua-5.1.so
b61aa000 b61b1000 r-xp /usr/lib/libembryo.so.1.7.99
b61ba000 b61de000 r-xp /usr/lib/libjpeg.so.8.0.2
b61f6000 b620d000 r-xp /lib/libz.so.1.2.5
b6215000 b621d000 r-xp /usr/lib/libvconf.so.0.2.45
b621e000 b622d000 r-xp /usr/lib/libsensor.so.1.1.0
b6238000 b623e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6246000 b6253000 r-xp /usr/lib/libail.so.0.1.0
b625c000 b6274000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6275000 b6278000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6280000 b62c0000 r-xp /usr/lib/libcurl.so.4.3.0
b62c9000 b62cd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b62d6000 b62db000 r-xp /usr/lib/libffi.so.5.0.10
b62e3000 b62e4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b62ec000 b62f6000 r-xp /usr/lib/libXext.so.6.4.0
b62ff000 b6302000 r-xp /usr/lib/libXtst.so.6.1.0
b630a000 b6310000 r-xp /usr/lib/libXrender.so.1.3.0
b6318000 b631e000 r-xp /usr/lib/libXrandr.so.2.2.0
b6326000 b6327000 r-xp /usr/lib/libXinerama.so.1.0.0
b6330000 b6339000 r-xp /usr/lib/libXi.so.6.1.0
b6341000 b6344000 r-xp /usr/lib/libXfixes.so.3.1.0
b634c000 b634e000 r-xp /usr/lib/libXgesture.so.7.0.0
b6356000 b6357000 r-xp /usr/lib/libXdamage.so.1.1.0
b6360000 b6367000 r-xp /usr/lib/libXcursor.so.1.0.2
b636f000 b63d9000 r-xp /usr/lib/libpixman-1.so.0.28.2
b63e6000 b640a000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6413000 b645e000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b6467000 b647b000 r-xp /usr/lib/libfribidi.so.0.3.1
b6483000 b64db000 r-xp /usr/lib/libfreetype.so.6.8.1
b64e6000 b64ee000 r-xp /usr/lib/libemotion.so.1.7.99
b64f6000 b6511000 r-xp /usr/lib/libecore_con.so.1.7.99
b651a000 b651f000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6528000 b6530000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6538000 b653a000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6542000 b6546000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b654f000 b6565000 r-xp /usr/lib/libefreet.so.1.7.99
b656f000 b6578000 r-xp /usr/lib/libedbus.so.1.7.99
b6580000 b6585000 r-xp /usr/lib/libecore_fb.so.1.7.99
b658e000 b65eb000 r-xp /usr/lib/libedje.so.1.7.99
b65f4000 b660b000 r-xp /usr/lib/libecore_input.so.1.7.99
b6626000 b662b000 r-xp /usr/lib/libecore_file.so.1.7.99
b6633000 b6672000 r-xp /usr/lib/libeina.so.1.7.99
b667b000 b668e000 r-xp /usr/lib/libeet.so.1.7.99
b6697000 b6701000 r-xp /lib/libm-2.13.so
b670a000 b670e000 r-xp /usr/lib/libappcore-common.so.1.1
b6717000 b671a000 r-xp /usr/lib/libproc-stat.so.0.2.82
b6722000 b672d000 r-xp /usr/lib/libaul.so.0.1.0
b6736000 b6754000 r-xp /usr/lib/libecore_evas.so.1.7.99
b675d000 b6791000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b679a000 b67c9000 r-xp /usr/lib/libecore_x.so.1.7.99
b67d3000 b67e8000 r-xp /usr/lib/libecore.so.1.7.99
b67ff000 b68af000 r-xp /usr/lib/libevas.so.1.7.99
b68c9000 b69ef000 r-xp /usr/lib/libelementary.so.1.7.99
b6a09000 b6a0c000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b6a14000 b6a1a000 r-xp /usr/lib/egl/eglsubX11.so
b6a22000 b6a25000 r-xp /lib/libattr.so.1.1.0
b6a2d000 b6a2f000 r-xp /usr/lib/libXau.so.6.0.0
b6a37000 b6a3d000 r-xp /lib/librt-2.13.so
b6a46000 b6a4e000 r-xp /lib/libcrypt-2.13.so
b6a7e000 b6a81000 r-xp /lib/libcap.so.2.21
b6a89000 b6a8b000 r-xp /usr/lib/libiri.so
b6a93000 b6aa8000 r-xp /usr/lib/libxcb.so.1.1.0
b6ab0000 b6abb000 r-xp /lib/libunwind.so.8.0.1
b6ae9000 b6c06000 r-xp /lib/libc-2.13.so
b6c14000 b6c1d000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c25000 b6c51000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c5a000 b6c5d000 r-xp /usr/lib/libbundle.so.0.1.22
b6c65000 b6c67000 r-xp /lib/libdl-2.13.so
b6c70000 b6c73000 r-xp /usr/lib/libsmack.so.1.0.0
b6c7b000 b6d55000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d5e000 b6d72000 r-xp /lib/libpthread-2.13.so
b6d7d000 b6d7f000 r-xp /usr/lib/libdlog.so.0.0.0
b6d87000 b6df4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6dfe000 b6e08000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e10000 b6ef6000 r-xp /usr/lib/libX11.so.6.3.0
b6f06000 b6f08000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6f10000 b6f15000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1e000 b6f1f000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f27000 b6f2b000 r-xp /usr/lib/libsys-assert.so
b6f33000 b6f50000 r-xp /lib/ld-2.13.so
be838000 be859000 rwxp [stack]
b6f10000 b6f15000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f1e000 b6f1f000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f27000 b6f2b000 r-xp /usr/lib/libsys-assert.so
b6f33000 b6f50000 r-xp /lib/ld-2.13.so
be838000 be859000 rwxp [stack]
End of Maps Information

Callstack Information (PID:18344)
Call Stack Count: 20
 0: (0xb47d3960) [/usr/lib/osp/libosp-appfw.so] + 0x216960
 1: (0xb42a4b4b) [/usr/lib/libcapi-system-power.so.0] + 0xb4b
 2: (0xb621b505) [/usr/lib/libvconf.so.0] + 0x6505
 3: (0xb6cdf783) [/usr/lib/libglib-2.0.so.0] + 0x64783
 4: g_main_context_dispatch + 0xce (0xb6cb3a37) [/usr/lib/libglib-2.0.so.0] + 0x38a37
 5: (0xb67e2337) [/usr/lib/libecore.so.1] + 0xf337
 6: (0xb67dd8b9) [/usr/lib/libecore.so.1] + 0xa8b9
 7: (0xb67de2f3) [/usr/lib/libecore.so.1] + 0xb2f3
 8: ecore_main_loop_begin + 0x30 (0xb67de5cd) [/usr/lib/libecore.so.1] + 0xb5cd
 9: elm_run + 0x6 (0xb6976817) [/usr/lib/libelementary.so.1] + 0xad817
10: appcore_efl_main + 0x362 (0xb6f133f3) [/usr/lib/libappcore-efl.so.1] + 0x33f3
11: app_efl_main + 0xc6 (0xb42e2ed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
12: Tizen::App::_AppImpl::Execute(Tizen::App::_IAppImpl*) + 0xee (0xb46ae83b) [/usr/lib/osp/libosp-appfw.so] + 0xf183b
13: Tizen::App::UiApp::Execute(Tizen::App::UiApp* (*)(), Tizen::Base::Collection::IList const*) + 0x64 (0xb3ea7679) [/usr/lib/osp/libosp-uifw.so] + 0x695679
14: OspMain + 0x1ac (0xb251d660) [/opt/apps/docomo7003/bin/MyHondana.exe] + 0x30660
15: main + 0x258 (0xb261ff15) [/opt/apps/docomo7003/bin/MyHondana] + 0xf15
16: (0xb363) [/usr/bin/launchpad_preloading_preinitializing_daemon] + 0xb363
17: (0xbc63) [/usr/bin/launchpad_preloading_preinitializing_daemon] + 0xbc63
18: __libc_start_main + 0x114 (0xb6afe6e8) [/lib/libc.so.6] + 0x156e8
19: (0xa0d4) [/usr/bin/launchpad_preloading_preinitializing_daemon] + 0xa0d4
End of Call Stack

Package Information
Package Name: docomo7003.MyHondana
Package ID : docomo7003
Version: 1.0.0
Package Type: tpk
App Name: d book MyShelf
App ID: docomo7003.MyHondana
Type: Application
Categories: (NULL)
